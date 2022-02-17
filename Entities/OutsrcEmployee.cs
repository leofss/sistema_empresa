namespace sistema_empresa.Entities
{
    class OutsrcEmployee : Employee
    {
        public double AddCharge { get; set; }


        public OutsrcEmployee()
        {

        }

        public OutsrcEmployee(double addCharge, string name, int hours, double valuePerHour)
            : base(name, hours, valuePerHour)
        {
            AddCharge = addCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AddCharge; //110% * addcharge
        }
    }
}
