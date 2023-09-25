using System.Collections.Generic;

namespace BusinessLayer.DTO
{
	public class TemplateAddDto  
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IEnumerable<TemplateItemAddDto> Items { get; set; }
	}
}