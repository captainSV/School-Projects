def RandGen()
  return rand(1..20)
end
def FrstGuess()
  print "What is the number: "
  nnumber = gets.chomp.to_i
  return nnumber
end
def Wrong(x, y) 
  if (x != y) 
    puts "That's not the correct number, guess again"
    return false
  else
    return true
  end
end
number = RandGen()
nnumber = FrstGuess()
sent = 1
while (sent != 2)
  while (Wrong(number,nnumber) == false) 
    nnumber = gets.chomp.to_i
  end
  puts "You guessed correctly!\nWould you like to quit? (Enter 2 to quit)"
  sent = gets.chomp.to_i
  if (sent == 2) 
    break
  end
  number = RandGen()
  nnumber = FrstGuess()
end 