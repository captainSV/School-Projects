#include <iostream>

using namespace std;
 
// function declaration
int YearlyInventory(int start, double replinRate, double deplinrate);
 
int main () {
   // local variable declaration and assignment
   int start;
   cout << "Please enter an integer value for starting inventory: ";
   cin >> start;
   double replin;
   cout << "Please enter an decimal between 0 and 1  for inventory replinishment value: ";
   cin >> replin;
   double deplete;
   cout << "Please enter an decimal between 0 and 1 for inventory depletion value: ";
   cin >> deplete;
   int year;
   cout << "Please enter an integer for the number of years: ";
   cin >> year;
   int yearlyinvin [year];
  
   // Array building
   for(int i = 0; i < year; i++){
     if (i == 0)
       yearlyinvin[i] = YearlyInventory(start, replin, deplete); //calling function
     else
       yearlyinvin[i] = YearlyInventory(yearlyinvin[i-1], replin, deplete); //calling function on previous years value
   }
   
   for(int j = 1;j < year;j++) {//print per year, barring final year
     cout << "Year ending inventory for year " << (j) << " is: " << yearlyinvin[j-1] << "\n"; //printing result
   }

   cout << "Final year end inventory is: "<< yearlyinvin[year-1] << "\n";
   return 0;
}
 
// function returning the end inventory after a single year
int YearlyInventory(int start, double replinRate, double deplinRate) {
   // local variable declaration
   int result = start * (1 + replinRate - deplinRate); //formula given in problem description

   return result; 
}