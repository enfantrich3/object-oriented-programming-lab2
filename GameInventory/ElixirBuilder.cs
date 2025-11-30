using GameInventory;

namespace GameInventory
{
    public class ElixirBuilder
    {
        private string name = "Неизвестный эликсир";
        private string info = "Таинственная жидкость в хрустальном флаконе";
        private string effect = "Свойства неизвестны";

        public ElixirBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public ElixirBuilder SetInfo(string info)
        {
            this.info = info;
            return this;
        }

        public ElixirBuilder SetEffect(string effect)
        {
            this.effect = effect;
            return this;
        }

        public Elixir Build()
        {
            return new Elixir(name, info, effect)
            {
                Name = name,
                Info = info 
            };
        }
    }
}