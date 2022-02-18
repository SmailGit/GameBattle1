namespace GameBatle
{
    /// <summary>
    /// Абстрактный класс Броня
    /// </summary>
    internal abstract class Armor : ILoot
    {
        private string name;
        private int durability;


        public string Name { get => name; set => name = value; }
        public int Durability { get => durability; set => durability = value; }

        public void Buff(int treatment)
        {
            Durability = Durability + treatment;

        }

        public void Debuff(int Damage)
        {
            Durability -= Damage;

        }

        public ILoot Use()
        {
            return this;
        }
    }
}