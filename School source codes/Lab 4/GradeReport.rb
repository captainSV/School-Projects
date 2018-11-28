puts "What was your grade on the test?"
grade = gets.chomp.to_i
case grade
  when 100
    puts "That grade is a perfect score. Well done."
  when 90..99
    puts "That grade is well above average. Excellent work."
  when 80..89
    puts "That grade is above average. Nice job."
  when 70..79
    puts "That is average work."
  when 60..69
    puts "That grade is not good, you should seek help!"
  when 0..50
    puts "That grade is not passing."
  else 
    puts "Something went horriably, horriably wrong! Or you entered an invalid grade."
end