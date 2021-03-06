using NUnit.Framework;
using PolyPerfect.Crafting.Framework;

namespace PolyPerfect.Crafting.Integration.Tests
{
    public class ItemStackTests
    {
        [Test]
        public void SlotWithCapacityRemainderCheck()
        {
            var item = new ItemStack(RuntimeID.Random(), 10);
            var slot = new ItemStackSlotWithCapacity(7);

            Assert.AreEqual(3, slot.RemainderIfInserted(item).Value.Value);
            Assert.AreEqual(3, slot.InsertPossible(item).Value.Value);
        }
    }
}