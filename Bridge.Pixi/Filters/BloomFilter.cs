namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// The BloomFilter applies a Gaussian blur to an object.
	/// The strength of the blur can be set for x- and y-axis separately.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class BloomFilter : AbstractFilter
	{
		public extern BloomFilter();

		/// <summary>
		/// Sets the strength of both the blurX and blurY properties simultaneously.
		/// </summary>
		[FieldProperty]
		public float Blur { get; set; }

		/// <summary>
		/// Sets the strength of the blurX property.
		/// </summary>
		[FieldProperty]
		public float BlurX { get; set; }

		/// <summary>
		/// Sets the strength of the blurY property.
		/// </summary>
		[FieldProperty]
		public float BlurY { get; set; }
	}
}