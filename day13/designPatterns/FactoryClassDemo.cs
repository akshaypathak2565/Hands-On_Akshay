using System;

namespace FirstProject.day13.designPatterns.FactoryClass {
    
    interface ICard {
        public double getAnnualChargeFees();
        public double getCardLimit();
        public void getCardType();
    }

    class GoldCard : ICard {
        public double getAnnualChargeFees() {
            return 1000;
        }

        public double getCardLimit() {
            return 1000000;
        }

        public void getCardType() {
            Console.WriteLine("Gold Type Card");
        }
    }

    class DiamondCard : ICard {
        public double getAnnualChargeFees() {
            return 2500;
        }

        public double getCardLimit() {
            return 2500000;
        }

        public void getCardType() {
            Console.WriteLine("Diamond Type Card");
        }
    }

    class PlatinumCard : ICard {
        public double getAnnualChargeFees() {
            return 5000;
        }

        public double getCardLimit() {
            return 5000000;
        }

        public void getCardType() {
            Console.WriteLine("Platinum Type Card");
        }
    }

    class CardFactory {

        public static ICard GetCard(string cardType) {

            ICard card;

            switch(cardType.ToUpper()) {
                case "GOLD":
                    card = new GoldCard();
                    break;
                case "DIAMOND":
                    card = new DiamondCard();
                    break;
                case "PLATINUM":
                    card = new PlatinumCard();
                    break;
                default:
                    throw new Exception("Specified Card type not Supported");
            }

            return card;
        }

    }


    class Demo {
        static void Main(string[] args) {

            // Without using Factory Method
            var goldCard = new GoldCard();
            goldCard.getCardType();
            Console.WriteLine($"Card Limit : {goldCard.getCardLimit()}");
            Console.WriteLine($"Card Annual Charge : {goldCard.getAnnualChargeFees()}");

            Console.WriteLine("--------------------");

            // With using Factory Method
            var card = CardFactory.GetCard("gold");
            card.getCardType();
            Console.WriteLine($"Card Limit : {card.getCardLimit()}");
            Console.WriteLine($"Card Annual Charge : {card.getAnnualChargeFees()}");

            Console.WriteLine("--------------------");

            card = CardFactory.GetCard("diamond");
            card.getCardType();
            Console.WriteLine($"Card Limit : {card.getCardLimit()}");
            Console.WriteLine($"Card Annual Charge : {card.getAnnualChargeFees()}");

            Console.WriteLine("--------------------");

            card = CardFactory.GetCard("platinum");
            card.getCardType();
            Console.WriteLine($"Card Limit : {card.getCardLimit()}");
            Console.WriteLine($"Card Annual Charge : {card.getAnnualChargeFees()}");
        }
    }
}
