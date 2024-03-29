using Godot;

namespace Moreus;
[Tool]
public partial class Item : Node2D, IPickable
{
    [Export]
    public Texture2D ItemIcon
    {
        get
        {
            var childlist = GetChildren();
            foreach (Node node in childlist)
                if (node is Sprite2D sprite2D)
                    return sprite2D.Texture;
            return null;
        }
        set
        {

            var childlist = GetChildren();
            foreach (Node node in childlist)
                if (node is Sprite2D sprite2D)
                    sprite2D.Texture = value;

        }
    }
    [Export] public int maxStack = 99;

    public bool DisableCollisions
    {
        get
        {
            return GetNode<CollisionShape2D>("Area2D/CollisionShape2D").Disabled;
        }
        set
        {
            GetNode<CollisionShape2D>("Area2D/CollisionShape2D").Disabled = value;
        }
    }

    public void Pick()
    {
        GD.Print("Debug Pick " + Name);
    }
}