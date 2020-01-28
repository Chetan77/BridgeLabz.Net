using System;

namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for string replace enter 1 \nfor flip coin enter 2 \nfor leafyear enter 3" +
                "\nfor power of two enter 4 \nfor harmonic sum enter 5 \nfor prime factor enter 6 \nfor 2dArray enter 7" +
                "\nfor sum of three numbers adds to zero enter 8 \nfor ecludian distance enter 9" +
                "\nfor quadratic roots enter 10 \nfor wind chill enter 11 \nfor gambler enter 12" +
                "\nfor coupon numbers enter 13 \nfor elapsed time enter 14 \nfor tic toc toe enter 15" );
            int n = Utility.IntInput();
            switch (n) {
                case 1:
                    StringReplace.ReplaceString();
                    break;
                case 2:
                    FlipCoin.FlipCoinPercent();
                    break;
                case 3:
                    LeapYear.IsLeapYear();
                    break;
                case 4:
                    PowerOfTwo.printTable();
                    break;
                case 5:
                    HarmonicSum.nthHarmonic();
                    break;
                case 6:
                    PrimeFactors.PrimeFactoirs();
                    break;
                case 7:
                    Array2D.Array2DElements();
                    break;
                case 8:
                    SumOfThreeAddsToZero.SumOfThree();
                    break;
                case 9:
                    EcludianDistance.Distance();
                    break;
                case 10:
                    QuadraticRoots.roots();
                    break;
                case 11:
                    WindChill.Chill();
                    break;
                case 12:
                    Gambler.GamblerSimulator();
                    break;
                case 13:
                    CouponNumbers.collect();
                    break;
                case 14:
                   StopWatchPrgm.StopwatchElapsedTime();
                   break;
                case 15:
                    TicTacToe.play();
                    break;
                default:
                    Console.WriteLine("enter correct value");
                    break;
            }
        }
    }
}
