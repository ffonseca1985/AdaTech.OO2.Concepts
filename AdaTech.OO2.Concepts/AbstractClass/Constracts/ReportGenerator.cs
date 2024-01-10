
namespace AbstractClass.Constracts
{
    public abstract class ReportGenerator
    {
        //Virtual => Possibilitar fazer a sobrescrita => Override
        public virtual void Build()
        {
            this.GenerateHeader();
            this.GenerateBody();
        }

        //Abstract => Cada um monta do seu jeito
        protected abstract void GenerateBody();
        protected abstract void GenerateHeader();
    }
}