#include <iostream>
#include <string>
#include <cstring>


using namespace std;
//int n = 0;
bool isPalindrome(int x) {
    //complete the function
  //convertimos el int en un string
    string numero = to_string(x);
  //obtenemos el tamaño del string para usarlo como rango de caracteres
    int n = numero.length()-1;
  //declaramos arreglos de char que contendrán la palabra y su versión inversa
    char palabra[20];//el número debería ser asignado con n, pero necesitaba una constante
    char pinversa[20];
  //rellenamos el de palabra con nuestro int hecho string 
  //puede variar que acepte strcpy o strcpy_s
    strcpy_s(palabra, numero.c_str());
  //declaramos dos strings para asignar a ellos los char array
    string normal, inverso;
  //llenamos inversamente el string inverso
    for (int i = 0; i <= n; i++) {
        pinversa[i] = palabra[n - i];
    }
  //llenamos los strings con los primeros puestos del arreglo que son los que están llenos
    for (int i = 0; i <= n; i++) {
        normal+=palabra[i];
        inverso += pinversa[i];
    }
 
    //comparamos para comprobar si es o no palindromo y listo
    if (normal ==inverso) {
        return true;
    }
    else {
        return false;
    }
    
}

int main() {
    int n;
    cin >> n;
    //isPalindrome(n);
    if (isPalindrome(n)) {
        cout << n << " is a palindrome";
    }
    else {
        cout << n << " is NOT a palindrome";
    }
    return 0;
}
