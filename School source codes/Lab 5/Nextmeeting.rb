currentday = Array["Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"]
puts "Enter the value representing the date:"
currentdate = gets.chomp.to_i
puts "How many days untill your meeting?"
daystil = gets.chomp.to_i
date = (currentdate+daystil) % 7;
puts "Today is #{currentday[currentdate % 7]}"
puts "Days until meeting is #{daystil} days"
puts "meeting day is #{currentday[date]}"