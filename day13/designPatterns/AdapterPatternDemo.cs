using System;

namespace FirstProject.day13.designPatterns.AdapterPattern {

    public interface ILightningPhone {
        void ConnectLightning();
        void Recharge();
        void Display();
    }
    public interface IUsbPhone {
        void ConnectUsb();
        void Recharge();
        void Display();
    }
    public class AndroidPhone : IUsbPhone {
        private bool isConnected;
        public void ConnectUsb() {
            this.isConnected = true;
            Console.WriteLine("Android Phone Connected to USB");
        }
        public void Display() {
            Console.WriteLine("Android Phone Started");
        }
        public void Recharge() {
            if (this.isConnected) {
                Console.WriteLine("Android Phone is Charging...");
            } else {
                Console.WriteLine("Please Connect the USB Cable for Charging");
            }
        }
    }
    public class iPhone : ILightningPhone {
        private bool isConnected;
        public void ConnectLightning() {
            this.isConnected = true;
            Console.WriteLine("iPhone Connected to the Lightning Charger...");
        }
        public void Display() {
            Console.WriteLine("iPhone Display Started...");
        }
        public void Recharge() {
            if (this.isConnected) {
                Console.WriteLine("iPhone is Charging...");
            } else {
                Console.WriteLine("Please connect the Lightning Cable for Charging");
            }
        }
    }
    public class LightningToUsbAdapter : IUsbPhone {
        private bool isConnected;
        public ILightningPhone LightningPhone { get; }
        public LightningToUsbAdapter(ILightningPhone lightningPhone) {
            LightningPhone = lightningPhone;
            this.LightningPhone.ConnectLightning();
        }

        public void ConnectUsb() {
            this.isConnected = true;
            Console.WriteLine("Adapter Cable Connected...");
        }
        public void Display() {
            this.LightningPhone.Display();
        }
        public void Recharge() {
            if (this.isConnected) {
                this.LightningPhone.Recharge();
            } else {
                Console.WriteLine("Connect USB to Lightning Cable for Charging");
            }
        }
    }


        class Demo {
        static void Main(string[] args) {
            ILightningPhone iPhone = new iPhone();
            IUsbPhone phoneAdapter = new LightningToUsbAdapter(iPhone);
            phoneAdapter.ConnectUsb();
            phoneAdapter.Recharge();
            phoneAdapter.Display();

        }
    }
}
