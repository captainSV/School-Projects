print "Entered string: "
letter = gets.chomp.chars
i = 0
loop do
  print "Letter: "
  puts letter[i]
  i += 1
  if i >= letter.length
    break
  end
end
