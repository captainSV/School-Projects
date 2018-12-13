def printChars(value, a, b)
  valarr = value.chars
  posA = valarr.index(a)
  posB = valarr.index(b)
  if (posA == nil) 
    return ""
  end 
  if (posB == nil)
    return ""
  end
  if (posA >= posB)
    return ""
  end
  return value[posA..posB]
end
def yeet (yeeet)
  count = 0
  while (count < yeeet.length)
    if (count%5 == 0)
      puts "\n"
    end
    print yeeet[count]
    count+= 1
  end
end
test = "0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz"
print "What is the start Character: "
start = gets.chomp
print "What is the end Character: "
endd = gets.chomp
testing = printChars(test,start, endd)
if (testing == "") 
  puts "start and end characters are out of order. Try again."
else
  yeet(testing)
end