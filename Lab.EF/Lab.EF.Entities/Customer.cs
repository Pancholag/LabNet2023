namespace Lab.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
            CustomerDemographics = new HashSet<CustomerDemographic>();
        }

        [Key]
        [StringLength(5)]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(30)]
        public string ContactName { get; set; }

        [StringLength(30)]
        public string ContactTitle { get; set; }

        [StringLength(60)]
        public string Address { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(15)]
        public string Region { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(15)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [StringLength(24)]
        public string Fax { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerDemographic> CustomerDemographics { get; set; }

        public override string ToString() 
        {
            var ret = $"Nombre de la compania :   {CompanyName} " +
                    $"\nNombre de contacto :    {ContactName}" +
                    $"\nTitulo de contacto :    {ContactTitle}" +
                    $"\nDireccion :             {Address}" +
                    $"\nCiudad :                {City}" +
                    $"\nRegion :                {Region}" +
                    $"\nCodigo Postal :         {PostalCode}" +
                    $"\nPais :                  {Country}" +
                    $"\nTelefono :              {Phone}" +
                    $"\nFax :                   {Fax}" +
                    $"\nOrdenes :";

            foreach (var item in Orders) 
            {
                ret += $"\n   ID de la orden {item}";
            }

            return ret;
        }
    }
}
