#include<iostream>
#include<conio.h>
using namespace std;

int main()
{
    string n[1][5];

    cout << "  Enter your name: ";
  
    cin >> n[0][0];
    system("cls");
    char x;
    float total, sum = 0, drink = 0, ulam = 0, dessert = 0, rice = 0;
    do {

        cout << "---------------Menu--------------\n\n";
        cout << "    [a] for drinks >> " << n[0][1] << drink << "\n";
        cout << "    [b] for Ulam   >> " << n[0][2] << ulam << "\n";
        cout << "    [c] for dessert>> " << n[0][3] << dessert << "\n";
        cout << "    [d] for rice   >> " << n[0][4] << rice << "\n";
        cout << "\n   [x] to stop and see the total bill\n\n";
        cout << "\n    please choose : ";
        cin >> x;
        
        system("cls");

        if (x == 'A' || x == 'a') {
            char d;

            cout << "-----------Menu for drinks---------\n\n";
            cout << "          [a] juice 10 pesos\n";
            cout << "          [b] gulaman 15 pesos\n";
            cout << "          [c] coke  20 pesos\n";
            cout << "          [d] ------skip-------\n";
            cout << "\n    please choose : ";
            cin >> d;
            system("cls");

            if (d == 'a' || d == 'A') {
                n[0][1] = "juice: ";
                drink = 10;
            }
            else if (d == 'b' || d == 'B') {
                n[0][1] = "gulaman: ";
                drink = 15;
            }
            else if (d == 'c' || d == 'C') {
                n[0][1] = "coke: ";
                drink = 20;
            }
            else if (d == 'd' || d == 'D') {

                drink = 0;
            }


        }



        else if (x == 'b' || x == 'B') {
            char d;

            cout << "-----------Menu for ulam---------\n\n";
            cout << "          [a] afritada 50 pesos\n";
            cout << "          [b] adobo 45 pesos\n";
            cout << "          [c] bistek 65 pesos\n";
            cout << "          [d] ------skip-------\n";
            cout << "\n    please choose : ";
            cin >> d;
            system("cls");





            if (d == 'a' || d == 'A') {
                n[0][2] = "afritada: ";
                ulam = 50;
            }
            else if (d == 'b' || d == 'B') {
                n[0][2] = "adobo: ";
                ulam = 45;
            }
            else if (d == 'c' || d == 'C') {
                n[0][2] = "bistek: ";
                ulam = 65;
            }
            else if (d == 'd' || d == 'D') {

                ulam = 0;
            }

  

        }

        else if (x == 'c' || x == 'C') {
            char d;

            cout << "-----------Menu for dessert---------\n\n";
            cout << "          [a] salad 35 pesos\n";
            cout << "          [b] ube langka 55 pesos\n";
            cout << "          [c] ice cream 18.5 pesos\n";
            cout << "          [d] ------skip-------\n";
            cout << "\n    please choose : ";
            cin >> d;
            system("cls");


            if (d == 'a' || d == 'A') {
                dessert = 35;
                n[0][3] = "salad: ";
            }

            else if (d == 'b' || d == 'B') {
                dessert = 55;
                n[0][3] = "ube langka: ";
            }

            else if (d == 'c' || d == 'C') {
                dessert = 18.5;
                n[0][3] = "ice cream: ";
            }

            else if (d == 'd' || d == 'D') {
                dessert = 0;
            }
       
        }

        else if (x == 'd' || x == 'D')
        {
            char z, d;

            cout << "-----------Menu for rice---------\n\n";
            cout << "          [a] plain rice 10 pesos\n";
            cout << "          [b] sinangag 15 pesos\n";
            cout << "          [c] special rice 15 pesos\n";
            cout << "          [d] ------skip-------\n";
            cout << "\n    please choose : ";
            cin >> d;
            system("cls");

            if (d == 'a' || d == 'A') {
                rice = 10;
                n[0][4] = "plain rice: ";
            }
            else if (d == 'b' || d == 'B') {

                rice = 15;
                n[0][4] = "sinangag: ";
            }
            else if (d == 'c' || d == 'C') {
                rice = 15;
                n[0][4] = "special rice: ";
            }
            else if (d == 'd' || d == 'D') {

                ulam = 0;
            }

   

        }

        else if (x == 'x' || x == 'X') {
            x = 'x';

        }


        total = ulam + dessert + drink + rice;


    } while (x != 'x');
    cout << "\n" << n[0][0] << "'s total bill: " << total << "\n";
}