using E_Commerce_Api.Domain.Common;

namespace E_Commerce_Api.Domain.Entities
{
    public class Detail: EntityBase
    {
        public Detail()
        {

        }
        public Detail(string description, string title, int categoryId, Category category)
        {
            Description = description;
            Title = title;
            CategoryId = categoryId;
            Category = category;
        }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}
