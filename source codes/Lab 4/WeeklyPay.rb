puts "How many hours did you work?"
hours = gets.chomp.to_i
hourly = 10;
overtime = 15;
if (hours > 40)
  totalpaid = ((hours % 40) * overtime) + 400
else
  totalpaid = hours * hourly
end
puts "Gross earning is $#{totalpaid}"
