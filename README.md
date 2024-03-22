# FlowSpell
![logo with a centered flower in the background resembling a maze](https://github.com/PiotrWalczak2001/FlowSpell/blob/main/assets/flowspell.png)

## About
**FlowSpell** is a tool to easily create highly configurable workflow scenarios with multiple behaviours handling different events or exceptions. Order tasks to run in the background and according to the scheduler, delay and repeat actions as needed. Manage, create and modify your workflows using an intuitive user interface that can be downloaded in a separate package, saving you the time you would have spent implementing your own solution. Another useful feature can be the creation of snapshots of workflows, which can be restarted on the same environment or continue the workflow outside of our environment in the cloud, for example. How you choose to use FlowSpell's multitude of features is entirely up to you.

> *This project was started thanks to the initiative of the #100commit contest, so I apologize for meaningless commits or poor descriptions of commits, but the context of the whole project has evolved over time.*

## Current features
The solution is not yet production-ready and does not have all the functionality described.
An inventory of current capabilities can be found below:

...well it looks empty here....

## Planned features
#### Core
- background activities without loss of knowledge of status
- setting schedules and activating flows in accordance with them
- storage of flows
- creating flows by activity snapshots
- scaling of flows
- process monitoring and reporting
- containerisation of flows
- conditional flow configuration
- delaying activities
- holding the flow with the possibility of returning to the process
- configuring reactions to defined events and errors
- creation of looped flows
- configuring time limits for the flow and specific action
- different strategies for queuing and execution flows
- versioning and control of flows
- retry of flows and individual activities
- integration into external flows
- integration with Azure

#### Redis and LiteDB
- Most probably Redis will be used to store the state of flows, and for less demanding LiteDB

#### Azure
Thanks to cloud integration, you can secure your most important and critical workflows so that they are completed even in the event of a disaster in your environment.

- run or continue your workflows using azure
- integration with functionalities offered by azure

#### Assemblies
- an original fresh look at workflows using assemblies
- support for scaling workflows that overload distributed systems

#### UI
- management of flows through the UI

#### Scripts
- adding and running scripts

## How to use
(work in progress)

## How to install
In the future, after the first version is released, there will be an option to install the package from NuGet and through the command line but currently I am only sharing the code.

> I am currently expanding my knowledge on topics related to the package 20.03