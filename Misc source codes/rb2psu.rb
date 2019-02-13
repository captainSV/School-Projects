def TernToIfElse(yeet)
  yeet.lines.each do |a|
    indent = a.scan(/  /).size
    p a
    next unless a.match(/ \? | \: /)
    b = a.strip.insert(0, 'if (').split(/ \? | : /)
    p b
    b[0].insert(-1,")\n")
    b[1].insert(0,"#{' '*indent}  ").insert(-1,"\n#{' '*indent}else\n")
    b[2].insert(0,"#{' '*indent}  ").insert(-1,"\n#{' '*indent}end\n")
    test = " "*indent
    b.each do |c|
      test << c
    end
    yeet[a] = test
  end
  return yeet
end
a = ''
File.readlines(ARGV[0]).each do |line|
  a << line
end
asdf = TernToIfElse(a)
t = asdf.gsub(/if/,"IF").gsub(/else/,"ELSE").gsub(/class/,"CLASS").gsub(/def/,"DEF").gsub(/@/,"THIS.").gsub(/end/,"END").gsub(/ < /," EXTENDS ").gsub(/return/,"RETURN").gsub(/ = /," ← ")
t << "\nEND"
File.write('psuedo.txt', t)