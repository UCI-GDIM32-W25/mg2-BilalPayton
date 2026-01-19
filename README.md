# HW2
## Devlog

The plan I wrote in the MG2 break-down activity connects to the code I wrote by how it helped me give 
classes and GameObjects the components that they need. For example, for the Player GameObject my break-down 
identified that I needed to assign it a Rigidbody2D, SpriteRenderer, Collider2D, and a Player script component 
and I coded these components as variables in the GameObject's script to make them tunable in the inspector. My
break-down plan specifically also identified how MG2 needed a GameController class to update the points UI through
a text member variable that can be tuned in the inspector, and a Coin class to make the coins always move to the left 
using its Update() method. Additionally, the GameController class would also be used to Instantiate Coin GameObjects 
randomly using Random.Range() and when they were offscreen, I made a collider that would destroy the Coin to help
optimization. This plan resulted in me coding for the Player class  first, the Coin class second, and the GameController 
class last.



## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites