def pyramid(height)
  height.times do |n|
    print " " * (height - n)
    puts "*" * (2 * n + 1)
  end
end
pyramid 8