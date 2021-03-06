using System.Collections.Generic;
using PolyPerfect.Common;
using PolyPerfect.Crafting.Framework;
using UnityEngine;

namespace PolyPerfect.Crafting.Integration.Demo
{
    [RequireComponent(typeof(ItemSlotComponent))]
    public class ItemExtractQueue : PolyMono
    {
        public override string __Usage => "Each time an item is extracted, it swaps the item out for another one in the queue.";
        [SerializeField] List<ObjectItemStack> InitialItems = new List<ObjectItemStack>();
        readonly Queue<ItemStack> itemQueue = new Queue<ItemStack>();
        ItemSlotComponent slot;
        bool updateWhenChanged = true;

        void Start()
        {
            slot = GetComponent<ItemSlotComponent>();
            slot.Changed += Swap;
            foreach (var item in InitialItems) 
                itemQueue.Enqueue(item);
            Swap();
        }

        void Swap()
        {
            if (!updateWhenChanged)
                return;
            updateWhenChanged = false;

            var extracted = slot.ExtractAll();
            if (!extracted.IsDefault())
                itemQueue.Enqueue(extracted);
            slot.InsertCompletely(itemQueue.Dequeue());
            
            updateWhenChanged = true;
        }
    }
}