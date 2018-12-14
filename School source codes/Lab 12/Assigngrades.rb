count = 0
counter = 0
print "What is the Class size: "
size = gets.chomp.to_i
Classe = Array.new(size)
print "Enter their grades: "
while (count < size)
  test = gets.chomp.to_i
  if (test >= 0 && test <= 100)
    Classe[count] = test
    count += 1
  else
    puts "Invalid number, try again."
  end
end
while (counter < size)
  if(Classe[counter] <=100 && Classe[counter] >=90) 
    lettergrade = "A"
  elsif(Classe[counter] <= 89 && Classe[counter] >=80) 
    lettergrade = "B"
  elsif(Classe[counter] <= 79 && Classe[counter] >=70) 
    lettergrade = "C"
  elsif(Classe[counter] <= 69 && Classe[counter] >=60) 
    lettergrade = "D"
  else 
    lettergrade = "F"
  end
  puts "Student number #{counter+1}'s score is #{Classe[counter]} and their grade is an #{lettergrade}"
  counter += 1
end