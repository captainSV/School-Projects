puts "Enter your grades: "
grade1 = gets.chomp.to_i
grade2 = gets.chomp.to_i
grade3 = gets.chomp.to_i
grade4 = gets.chomp.to_i
gradearray = Array[grade1,grade2,grade3,grade4]
grademin = gradearray.min
grademax = gradearray.max
gradeaverage = (grade1 + grade2 + grade3 + grade4) / 4;
puts "You entered: #{grade1}, #{grade2}, #{grade3}, #{grade4}"
puts "Highest grade: #{grademax}"
puts "Lowest grade: #{grademin}"
puts "Average grade: #{gradeaverage}"