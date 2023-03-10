using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateCountryDTO
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 5, ErrorMessage = "Short Country Name is too long")]
        public string ShortName { get; set; }
    }
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotel {get;set;} 
        
    }
    
}
