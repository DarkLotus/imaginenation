using Server.Spells.Second;

namespace Server.Items
{
    public class RemoveTrapWand : BaseWand
    {
        [Constructable]
        public RemoveTrapWand() : base(15)
        {
            ItemID = 0xdf3;
            Name = "Remove Trap";
        }

        public RemoveTrapWand(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override void OnWandUse(Mobile from)
        {
            Cast(new RemoveTrapSpell(from, this));
        }
    }
}