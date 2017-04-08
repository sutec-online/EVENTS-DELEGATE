namespace ClassLibrary
{
    public class CargoVehicle
    {
        private string plate;
        private byte speed;
        private string brand = null;
        const byte limit = 110;

        public string Plate // Plaka 
        {
            get
            {
                return this.plate;
            }
            set
            {
                this.plate = value;
            }
        }

        public byte Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value > 0 ? value : (byte)0;
                if (this.speed >= limit)
                    SpeedExceeded(this);
            }
        }

        public string Brand //Marka
        {
            get
            {
                return this.brand;
            }
            set
            {
                this.brand = value;
            }
        }


        /////////////// Constructor ////////////
        public CargoVehicle(string plate)
        {
            this.Plate = plate;
        }

        public CargoVehicle(string plate, string brand) : this(plate)
        {
            this.Brand = brand;
        }

        public delegate void SpeedHandler(CargoVehicle vehicle);
        public event SpeedHandler SpeedExceeded;
    }
}
