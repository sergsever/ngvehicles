namespace vehiclesapi.Data.Entities
{
	public class VehicleTDO
	{
		public long cId { get; set; }
		public string cTitle { get; set; }
		public string cOriginDate { get; set; }
		public long? cPrice { get; set; }

		public VehicleTDO( long cId, string cTitle, string cOriginDate, long? cPrice)
		{
			this.cId = cId;
			this.cTitle = cTitle;
			this.cOriginDate = cOriginDate;
			this.cPrice = cPrice;
		}
	}
}
