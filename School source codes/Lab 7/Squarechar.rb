longsize = 1
counter = 1
print "What's the character?"
input = gets.chomp
print "What's the size?"
size = gets.chomp.to_i
puts "\n"
while (longsize <= size) 
  while (counter <= size)
    print "#{input}"
    counter += 1
  end
  puts "\n"
  longsize += 1
  counter = 1
end