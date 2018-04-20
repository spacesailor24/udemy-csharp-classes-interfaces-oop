namespace AccessModifiers
{
    using System;

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = this.CalculateRating(excludeOrder: true);

            if (rating == 0)
            {
                Console.WriteLine("Promoted to level 1");
            }
            else
            {
                Console.WriteLine("Promoted to level 2");
            }
        }

        private int CalculateRating(bool excludeOrder)
        {
            return 0;
        }
    }
}