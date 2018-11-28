puts "What is your name?"
username = gets.chomp
puts "What is your first grade?"
grade1 = gets.chomp.to_i
puts "What is your second grade?"
grade2 = gets.chomp.to_i
puts "What is your third grade?"
grade3 = gets.chomp.to_i
Average = (grade1+grade2+grade3)/3
puts "Your average is #{Average}"