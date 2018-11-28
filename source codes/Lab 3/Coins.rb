puts "Enter Number of Quarters: "
NQ = gets.chomp.to_i
puts "Enter Number of Dimes: "
ND = gets.chomp.to_i
puts "Enter Number of Nickles: "
NN = gets.chomp.to_i
puts "Enter Number of Pennies: "
NP = gets.chomp.to_i
puts "\nYou entered #{NQ} Quarters"
puts "You entered #{ND} Dimes"
puts "You entered #{NN} Nickles"
puts "You entered #{NP} Pennies\n\n"
NQuarters = NQ * 25
NDimes = ND * 10
NNickles = NN * 5
NPennies = NP * 1
Dollars = (NQuarters + NDimes + NNickles + NPennies) / 100
Cents = (NQuarters + NDimes + NNickles + NPennies) % 100
puts "Your total is #{Dollars} Dollars and #{Cents} Cents."