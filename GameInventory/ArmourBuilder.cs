using Lab2;

namespace GameInventory
{
    public class ArmourBuilder
    {
        private string name = "Неизвестная броня";
        private int protection = 0;
        private string info = "Нет описания";

        public ArmourBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public ArmourBuilder SetProtection(int protection)
        {
            this.protection = protection;
            return this;
        }

        public ArmourBuilder SetInfo(string info)
        {
            this.info = info;
            return this;
        }

        public Armour Build()
        {
            return new Armour(name, protection, info)
            {
                Name = name,
                Info = info
            };
        }
    }
}
