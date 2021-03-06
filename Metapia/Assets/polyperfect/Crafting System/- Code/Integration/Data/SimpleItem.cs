using PolyPerfect.Crafting.Framework;

namespace PolyPerfect.Crafting.Integration
{
    /// <summary>
    ///     Simple IHasID implementation
    /// </summary>
    public readonly struct SimpleItem : IHasID
    {
        public RuntimeID ID { get; }

        public SimpleItem(RuntimeID id)
        {
            ID = id;
        }

        public ItemStack WithAmount(int amount)
        {
            return new ItemStack(ID, amount);
        }
    }
}