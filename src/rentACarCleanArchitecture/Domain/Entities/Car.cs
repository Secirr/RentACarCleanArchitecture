using System;
using Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class Car : Entity<Guid>
	{
		public string Name { get; set; }

		public Guid ColorId { get; set; }

		public Guid BrandId { get; set; }

		public Guid ModelId { get; set; }

		public Guid DriveTypeID { get; set; } // 4x4

		public Guid TransmissionId { get; set; } // vites

		public Guid FuelTypeId { get; set; }

		public Guid StatuId { get; set; }

		public Guid FeatureId { get; set; }

        public bool IsAvailable { get; set; }

        public decimal DailyPrice { get; set; }

		public string ImageUrl { get; set; }

		public string Description { get; set; }

        public int Year { get; set; }

		public long Millage { get; set; } // km

		public Double EngineSize { get; set; }

		public int Door { get; set; }

		public int Cylinder { get; set; }







        public Feature Feature { get; set; }

        public Color Color { get; set; }

		public Statu Statu { get; set; }

		public FuelType FuelType { get; set; }

        public Transmission Transmission { get; set; }

		public DriveType DriveType { get; set; }

        public Brand Brand { get; set; }

        public Model Model { get; set; }



		
	}
}

