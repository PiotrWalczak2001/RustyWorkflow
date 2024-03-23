use axum::{
    routing::{get},
    Router,
};
use tokio::net::TcpListener;
use RustyWorkflow::workflows::workflow::run;

async fn get_handler() -> &'static str {
   run()
}

#[tokio::main]
async fn main() {
    let app = Router::new()
        .route("/", get(|| async { "Hello, World!" }))
        .route("/run", get(get_handler));

    let listener = TcpListener::bind("127.0.0.1:3000").await.unwrap();
    println!("Listening on {}", listener.local_addr().unwrap());
    axum::serve(listener, app).await.unwrap();
}
