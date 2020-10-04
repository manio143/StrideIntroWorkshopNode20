# Working with the Stride GameStudio
Materials for the "Working with the Stride GameStudio" workshop @ NODE20 Forum for digital arts.

## About this repository
This repository is setup such that each step in the workshop is added as a separate commit. If you happen to get completely lost during the workshop perform the following:

    git clone https://github.com/manio143/StrideIntroWorkshopNode20
    cd StrideIntroWorkshopNode20
    git checkout step_i

Where `i` is the index of the current workshop topic (see below). You should then be able to run the project and follow along with the workshop from that point on.

## Workshop structure
It's always good to have some goal. In our case we'll build a very simple 2D game with 3D graphics where the player controls a ball by moving it left and right. The ball is subject to gravity and lays on top of platforms which move upwards. Should the ball fall off the screen with no platform to land on or if the ball touches the ceiling - the game will be over and it will say so by displaying text on the screen. Whenever a platform disappears on the top of the screen, a new one will be spawned at the bottom with a random length and horizontal position.

![Finished game](img/dropball_s.gif)

To accomplish that goal we will go through the following lessons:

1. **Create a new project in Stride.**

    Here we'll learn a bit about the launcher, working with Stride for .NET Core vs .NET Framework, how to handle issues with the launcher, and finally about the project templates. We'll also take a look at the project files.
2. **Learn about entity hierarchy and the transform component.**

    I'll describe the Entities-Components-Systems architecture that Stride is based on and we will test how child entities work by creating a child entity and modifying theirs and their parent's transforms.
3. **Create a new cube asset and create our platform entity.**

    We'll browse the 'Add asset' context menu and see the model component in action.
4. **Create a script that moves the platform.**

    We'll talk about approaches to writing code for a game and use the built-in code editor or an external IDE and add rigidbody physics into our scene.
5. **Create a script that processes user input and moves the sphere.**

    We'll create a `SyncScript` and talk about the game loop, then we'll use simple logic to move the sphere.
6. **Create a prefab out of the platform.**

    We'll see how our entities with components with custom settings can be saved and reused from a script.
7. **Create a platform spawner.**

    When a platform leaves area of collision with the spawner a new platform will be created below, using the platform prefab.
8. **Create a platform remover.**

    When a platform enters a collision with the remover at the top of the screen it's going to be removed.
9. **Create sphere killer.**

    When sphere enters a collision with the killer all platforms are going to be destroyed and the game will be over. To achieve this we'll use global asynchronous events and a new component.
10. **Display a text message on game over.**

    Create a UI Page asset and show it upon game over.
