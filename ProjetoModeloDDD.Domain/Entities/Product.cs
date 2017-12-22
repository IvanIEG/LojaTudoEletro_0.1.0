namespace Ivan.LojaTudoEletro.Domain.Entities
{
    public class Product

    { 

        public int ProductId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string Details { get; set; }

        public bool Selloff { get; set; }
            
        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
