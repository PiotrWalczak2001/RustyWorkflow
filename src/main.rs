use axum::{
    routing::{get},
    Router,
    extract::Path,
    http::StatusCode,
};
use tokio::net::TcpListener;

pub mod greet {
    tonic::include_proto!("greet");
}
use crate::greet::HelloRequest;
use crate::greet::greeter_client::GreeterClient;

async fn call_greet(Path(name): Path<String>) -> Result<String, StatusCode> {
    let mut client = GreeterClient::connect("http://[::1]:5016").await.expect("Connection failed");

    let request = tonic::Request::new(HelloRequest {
        name,
    });

    let response = client.say_hello(request).await.expect("Request failed");
    Ok(format!("Response: {:?}", response.into_inner().message))
}

#[tokio::main]
async fn main() {
    let app = Router::new()
        .route("/", get(|| async { "Hello, World!" }))
        .route("/say_hello/:name", get(call_greet));

    let listener = TcpListener::bind("127.0.0.1:3000").await.unwrap();
    println!("Listening on {}", listener.local_addr().unwrap());
    axum::serve(listener, app).await.unwrap();
}
