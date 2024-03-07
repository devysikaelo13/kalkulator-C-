using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("--------------------------");
            Console.WriteLine("-- KALKULATOR SEDERHANA --");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. TAMBAH");
            Console.WriteLine("2. KURANG");
            Console.WriteLine("--------------------------");
            Console.WriteLine("MASUKKAN PILIHAN ANDA:");
            // Parsing -> ini adalah komentar 1 baris
            /*
             untuk komentar yang lebih dari 1 baris
             bisa menggunakan tanda garis miring/slash diikuti bintang
             dan ditutup dengan tanda bintang diikuti garis miring/slash
             */
            int pilihan = int.Parse(Console.ReadLine());
            if (pilihan == 1) {
                inputTambah();
            } else if (pilihan == 2) {
                inputKurang();
            }
            Console.WriteLine();
         }
        static void inputTambah() {
            Console.WriteLine("----------------------------");
            Console.WriteLine(" MASUKKAN ANGKA ke-1: ");
            //parsing
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" MASUKKAN ANGKA ke-2: ");
            string input2 = Console.ReadLine();
            int hasil_tambah = tambah(input1, int.Parse(input2));
            Console.WriteLine(">>> HASIL: " + hasil_tambah);
        }
        static int tambah(int angka1, int angka2) {
            int hasil = angka1 + angka2;
            return hasil;
        } 
        static void inputKurang() {
            Console.WriteLine("---------------------------");
            Console.WriteLine("MASUKKAN ANGKA ke-1: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("MASUKKAN ANGKA ke-2: ");
            string input2 = Console.ReadLine();
            int hasil_kurang = kurang(input1, int.Parse(input2));
            Console.WriteLine(">>> HASIL: " + hasil_kurang);
        }
        static int kurang(int angka1, int angka2) {
            int hasil = angka1 - angka2;
            return hasil;
        }
    }
}
