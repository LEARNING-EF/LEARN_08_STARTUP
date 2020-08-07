namespace Models
{
	public class Country : object
	{
		public Country() : base()
		{
			// Solution (2)
			Id = System.Guid.NewGuid();
			// /Solution (2)
		}

		// Solution (1)
		//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
		//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		//public System.Guid Id { get; set; }
		// /Solution (1)

		// Solution (2)
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; set; }
		// /Solution (2)

		// Solution (3)
		// Supported in EF 6.2.0
		//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
		//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		//public System.Guid Id { get; set; }
		// Solution (3)

		// Solution (4)
		// Supported in EF Core 2.x
		// Does Not Supported in EF 6.2.0
		//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
		//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed)]
		//public System.Guid Id { get; set; }
		// Solution (4)

		// Supported in EF Core 2.x
		// Does Not Supported in EF 6.2.0
		//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
		//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed)]
		//public System.DateTime InsertDateTime { get; set; }

		public string Name { get; set; }
	}
}
