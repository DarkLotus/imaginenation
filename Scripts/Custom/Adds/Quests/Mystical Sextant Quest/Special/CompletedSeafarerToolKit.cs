namespace Server.Items
{

	public class CompletedSeafarerToolKit : Item
	{
		[Constructable]
		public CompletedSeafarerToolKit() : this( null )
		{
		}

		[Constructable]
		public CompletedSeafarerToolKit ( string name ) : base ( 0x1EBA )
		{
			Name = "A Completed Seafarer's Tool Kit";
			LootType = LootType.Blessed;
			Hue = 263;
		}

		public CompletedSeafarerToolKit ( Serial serial ) : base ( serial )
		{
		}

		public override void Serialize ( GenericWriter writer)
		{
			base.Serialize ( writer );

			writer.Write ( 0);
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize ( reader );

			int version = reader.ReadInt();
		}
	}
}