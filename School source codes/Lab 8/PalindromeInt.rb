def Reverse(x)
  reverse = 0
  while(x!=0)    
    rem = x % 10        
    reverse = ((reverse * 10) + rem)      
    x /= 10
  end
  return reverse
end
def IsPalindrome(x)
  if (x == Reverse(x))
    k = 1
  else
    k = 0
  end
  return k
end
print "Please enter an integer: "
zed = gets.chomp.to_i
zedcheck = IsPalindrome(zed)
if (zedcheck == 1)
  puts "That is a palindrome! Good job."
else
  puts "That is not a palindrome! Try again."
end