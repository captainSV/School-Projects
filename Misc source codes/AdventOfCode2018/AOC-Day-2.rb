require 'set'
boxnum = ["vtnihorkulbfvjcyzmsjgdxplw", "vtnihorvujbfejcyzmsqgdlpaw", "vtnihoriulbzejcyzmsrgdxpaw", "vtsihowkulbfejcyzmszgdxpaw", "vtnizorkunbfejcyzmsqgdypaw", "vtnihorkdlbfojcyzmsqgdfpaw", "vtpioorkulbfejcysmsqgdxpaw", "vtnvhorkulbfhjcyzmsqgdipaw", "vtrihorkylbaejcyzmsqgdxpaw", "vtnigorkulbfejcyzmszgjxpaw", "rtnihorkklbfejcyzmslgdxpaw", "vtnihorkqlbfejcyzmsqgmppaw", "vgnisorkulbfejcyzmsqgdkpaw", "atnihorkulbfejcyzmdbgdxpaw", "vtnihorkulbfejcezmsqqixpaw", "vtnihorkucbfejcxzmsqgdypaw", "vtnihorkulxfajcyzmsqgyxpaw", "vbnihorkulbfescyzmsqgdxpae", "vanshorkulbfejcyzjsqgdxpaw", "vtnihoukulbfejcyzmwqgdxpbw", "vtndhorkulbfejcyxmgqgdxpaw", "ztnihlrkupbfejcyzmsqgdxpaw", "vtoihkrkulbfejhyzmsqgdxpaw", "vtnihorkalbiejcyzmsqgdxeaw", "vtnihorhulcfejcyzqsqgdxpaw", "vtnshotkulbfejcyzmsqvdxpaw", "vtnihoryulbfejcyzmsqgpspaw", "vtnihorkukbfmjcyzmsqgdxpcw", "vtnihorkulbfejcybmsqgdupxw", "vlnihorkulbfejcyzmsqgdmpac", "vtnihorkulbfejcezmfqgdkpaw", "vpnihorkulbfejcyzmsqfdxyaw", "vtnihorkulbjejcysmcqgdxpaw", "vdnihorkulffejcyzisqgdxpaw", "vtnihorkulkfsjcyzrsqgdxpaw", "vtnihorkulqfegoyzmsqgdxpaw", "vtnihorkulbfeyhyzgsqgdxpaw", "vnnihorkulbfejcyzmdqgdxpfw", "vtnihorkulstejcyzmsqgdxpak", "vtnphorkujbfejcczmsqgdxpaw", "vtpihorkulbfejcyzmskgdxiaw", "vtnihorkulbfejcdzmxqsdxpaw", "vtnihorgulbfticyzmsqgdxpaw", "veniuorkulbfejcyzmsqgdmpaw", "vhnihorkclbfejyyzmsqgdxpaw", "vtnihorkulbfejcyzmrqgsrpaw", "dtnihorkzlhfejcyzmsqgdxpaw", "vtnizorkulbfejcyzhsqgdxdaw", "vtnihohkulbfejcybmpqgdxpaw", "vtnihbrzulbfejcyzmsqgdppaw", "stnihorkulmfejcyzmsqgdxeaw", "vtnihorkulbfejmgzwsqgdxpaw", "vtnihcrkulbfnjdyzmsqgdxpaw", "vxxihorkulbfejcyzmsqddxpaw", "vtnhhorkulbfejcyzmsqgdpiaw", "vtnihoakulbfvjcyzmmqgdxpaw", "vtbbhorkulbfejcyqmsqgdxpaw", "vtnihnukulbfejcxzmsqgdxpaw", "vteihorgulkfejcyzmsqgdxpaw", "vbnihorkulbfejcyzmsqgdxpmt", "itnihorkulbuejcyzmsqgdxpxw", "vtnfhqrkulbfejcwzmsqgdxpaw", "vtnihorkubbfedcyzmsqpdxpaw", "rtnihorkulhfejcyzmsqgdxpah", "vtnihorzulbfejcyqmsqqdxpaw", "vtnihorkulbfeecyzmsqgdcgaw", "vtniuorkulbfejpyzmsqxdxpaw", "vtnicorkilbfajcyzmsqgdxpaw", "vtzihorkulbfejcyzmsqgaxpkw", "vtnihomkulbfejcyzmsqgvmpaw", "vznihockulbfejcyzmsqgdjpaw", "vtqmhorkulhfejcyzmsqgdxpaw", "ptnihorkulbfsjcyzbsqgdxpaw", "ftnihorkulbfejcepmsqgdxpaw", "vtnhhorkulbfejyyzxsqgdxpaw", "vtnihorkulbfejcyzmsiwdxpxw", "vtnikorkulbfejvyzmnqgdxpaw", "vtnihorkulbgejoyzmsqhdxpaw", "vtnihorkulbwejqylmsqgdxpaw", "vtnihorkdlbfejcyzwsqgdrpaw", "vtnihorkulbfojcyzmtugdxpaw", "vtnihonkulbtejcyzxsqgdxpaw", "vtnihorkulrfevcyzmsqgdxpcw", "vtnioorkulbfejcynmsqgdxpad", "vtnihorkudffejcyzhsqgdxpaw", "vtnihorkelbfejcqzmsqgdxbaw", "jtnihokkulbfejcyzmsqgdrpaw", "ztnihorrulbfejcyzlsqgdxpaw", "vtwiforkulbfejcyzmsqpdxpaw", "vtnihopvulbfejcyzmsqgzxpaw", "vtnihzrkulafejcyzmsqgdxpaj", "vtnixoekulbfejcyzmsqgdxpak", "vtnihorkulbfejxyzmsqgdxhlw", "vtnihorkulbfwjcyzmmqcdxpaw", "vtnihorkulbfejcywmsdgdxzaw", "vtnihorkulbfejfyzmsqggxuaw", "vtnihnrkurbfejcyzmsqggxpaw", "vtuihorkulbkejcyzmsqgdxpww", "vtnihoriuljfejcyzssqgdxpaw", "vtnihorkulyftjcezmsqgdxpaw", "vtnihorkklbfeccyzmsqgdppaw", "vtnihorkulbfdpcyzmsqgdxpcw", "vtnihqrkulgfejcyzmeqgdxpaw", "vtnihorktlbfejdyzmswgdxpaw", "vinihzrkulbfeacyzmsqgdxpaw", "vtuihorkupbfejcyzmsqgdxplw", "vtnihorkulbfcjcyzmlqgdxpsw", "vtnihorkllbfejcyzmsqgdxvak", "qtnihorkulbfdjcyzusqgdxpaw", "vtniherkulbhejcyzmsqgzxpaw", "vtnzhorgulbfejcyzmsqgdxpew", "vtnihoykulhfjjcyzmsqgdxpaw", "vtnihookulyfejcyzmsqgdxqaw", "jtnihorkulbfejcyzmssgdxpaq", "vtnicorkulwfejcyzmsxgdxpaw", "wtnihorkuubfejcyzmsqgdxpam", "vtnihorkuggfejcyzmsdgdxpaw", "vtnihurkulbfgjcyzmsqrdxpaw", "ptnihorkuabfejcyzmsqgqxpaw", "vtrihoykulbfejcyzmsqgdxpam", "otnihorkulbfejcyzmpqgdxpjw", "vtyihorkulbfejdyznsqgdxpaw", "vtnihornulbfrjcizmsqgdxpaw", "vtnihfrlulbfejcyzmsqgdxpah", "atnihorkulbfejcyossqgdxpaw", "vtnihorkuljfejcyzysqgdxpow", "vtniyorkulbfejcyzmsqgdxbaz", "venihorkulbfejctzmqqgdxpaw", "vtrihorkulbfejcyjmsqgdxpfw", "venitorkulbfexcyzmsqgdxpaw", "vtbihorkulbfejcyzmwqgdxpyw", "vtnihorkuubfejxyzmsqgdxkaw", "vtqihorkulbnejcyzmsqgdxnaw", "vteihorkurbfejcyzmsqwdxpaw", "vtgjhorkxlbfejcyzmsqgdxpaw", "ytniworkulbfejcyzmsqgdxptw", "vtnihorkulbfejcyzmsvgixhaw", "dtnihorkusbfejcyzmsqidxpaw", "vtnihurkulbfejcdzmkqgdxpaw", "vtgihorkulbfejcyzhsqgdxpaf", "vtniudrkulbfeacyzmsqgdxpaw", "vtnihorkulbfejcyemsokdxpaw", "vtnihorkulbfejcyjmwqgdxpag", "vtnihorpulbfetcpzmsqgdxpaw", "ctnzhorkulbfejcyzmfqgdxpaw", "vanihorkuhbwejcyzmsqgdxpaw", "vtnihonkurbfejcyzvsqgdxpaw", "vtnihgrkulbcejcbzmsqgdxpaw", "vtnihorkutbfeacyzmsqcdxpaw", "vtniaorkuhbfqjcyzmsqgdxpaw", "vtnihorkylbfozcyzmsqgdxpaw", "vtnihorkulbfejcypmfqgdxpbw", "vtrphonkulbfejcyzmsqgdxpaw", "vtnihorkulbdejcywmsqydxpaw", "vtnikorkulbfejvyzknqgdxpaw", "vznihorkulbfejcyzmsqbdxpam", "vtmghorkulbfejcyzmsqghxpaw", "vtnihorkulbfejcyzmshglxpfw", "vtiihorkulbfejcjzmsqgdxoaw", "rtnihorkulbfejcuzmsqgdxpow", "vtnthoikulbuejcyzmsqgdxpaw", "vtniholkulbfcjcyzmsqgdxpvw", "vdnihorkulbbejcyzmsqgdxdaw", "ntnihorkulbfojcyzmsqgdxzaw", "vtniqorkulbfejcyzklqgdxpaw", "vtnihorkulhfejcpzmsqgdxprw", "vhnihorkulqfejcyzmsqgdapaw", "vtnihorkolafejcyzmsqadxpaw", "vtnihorkulbpejcyzasqgtxpaw", "vtnihgiyulbfejcyzmsqgdxpaw", "dtnihorkulbffjcyzmsqgdfpaw", "vtnvhorhulbfejcyzmpqgdxpaw", "vtniholkulbfebcyzmsqgnxpaw", "vunihorkulbbejcyznsqgdxpaw", "vtnihorkulbfehcyomsqgaxpaw", "vtnihorkllboejcyzmsigdxpaw", "vtnihwrkulbfejcywmsqgdxiaw", "vtnoherkulbfbjcyzmsqgdxpaw", "vtnbhorkulbfejcyzmsqgkxpaa", "vtnihorkilbfdjxyzmsqgdxpaw", "vtnfhorkuvbfejcyzmsqgixpaw", "vtnyhorkulbpejcyzmsqgdxjaw", "vtnihomkalbfejcyzmqqgdxpaw", "vtnihorkulbfejcybmsqgjxvaw", "vtnihorkulbfgjcnzmsqbdxpaw", "vtnihorkulbfejcyzmpqgsxpap", "lmnihorkulbfejcizmsqgdxpaw", "vtmahkrkulbfejcyzmsqgdxpaw", "vtnihorkulbfujcyrcsqgdxpaw", "vtnzhorkulbfejcyzjvqgdxpaw", "vtnicorkulbfejmyzmsqgdxvaw", "vtnyhojkulbfejcyzmsngdxpaw", "vtnuhorkulbfejcyzlsqgdxpmw", "vtnihorkulufejcgzmtqgdxpaw", "vtnihfrkulbfejnyzmsigdxpaw", "vtnzhorkulbdejnyzmsqgdxpaw", "vttihorkulbfejcyzmyqgdxwaw", "vknihorkulbfejnylmsqgdxpaw", "vtnihorkulbfejcfrmsqgdxpaz", "vtnchormulbfejcyzmsqgdopaw", "vtnihorkulbfebcyzusqgdxpam", "jtnihorwulbfejcyzksqgdxpaw", "ctnihodkutbfejcyzmsqgdxpaw", "vonihorkultfejcyzmsqgixpaw", "vtnihorkulbqejcyzmsqgdypcw", "vfnihorkulbfbjcyzmsqcdxpaw", "utnihorkulbfejcyqmsqgdxraw", "vtnihorkjllfejcyzmskgdxpaw", "vtnihorkulbfejcyvisqgdapaw", "vtnihorkclzfejcyzmsqvdxpaw", "vtnihwrkvlffejcyzmsqgdxpaw", "vtnihlrkulbfejcrzmsqydxpaw", "vtnihorkulbfbjtysmsqgdxpaw", "vtnihorkulbfxjcepmsqgdxpaw", "ttnihorkulbfejpyzmsqgdxpaz", "vtnwhorkolbfejcdzmsqgdxpaw", "vtnihorkulbfejcyzdsqgdxppn", "vtnwporkulbfercyzmsqgdxpaw", "vtnshorxuvbfejcyzmsqgdxpaw", "vtnihxrkulbfejcyomsqfdxpaw", "vtnwhorkrljfejcyzmsqgdxpaw", "vqnihorkulbfejcyzmtqgdxpuw", "vtnnhorkulbfhrcyzmsqgdxpaw", "vtuihwrkulbfedcyzmsqgdxpaw", "vtgbhorkucbfejcyzmsqgdxpaw", "vtnitorkulbfejcozmsqgdkpaw", "otnihomkulbfejcyzmsqgdxhaw", "vtnihgrkulbfrjcyzmsqxdxpaw", "vtnihorkulbfujcyzmsqghxpzw", "vsnihopkhlbfejcyzmsqgdxpaw", "vtniherkulbfejcyzmpzgdxpaw", "vtnxhorkulbfejcszmsqgdxcaw", "vtnihorkulbfejctzmsxadxpaw", "vtnihorkslbmejcyzmsqgnxpaw", "vtnwhorgulbfegcyzmsqgdxpaw", "vtnihorkulbfsjcyzmsqgdxiau", "vtnihorkulbfejcyzmsqldxpbj", "vtnghorkulbfmjcyzmsqgdxpaa", "vtnihorkulbfetcyzmpqudxpaw", "vtnbhorkulbfejcyzmsqgdupyw", "ntnihorhulbfejwyzmsqgdxpaw", "vjnihorkulbfejcyqosqgdxpaw", "vtiihorbulbfejcbzmsqgdxpaw", "vtnihorkulbfejxlzmpqgdxpaw", "vtnihorkolbfejcyfmsqgdxraw", "vtnihqrrulbfedcyzmsqgdxpaw", "ctnihorkulbfejcyzmsqgdxpsy", "vtnihorkulbfkjcezmspgdxpaw", "ztnihorkulbmcjcyzmsqgdxpaw", "vinihorkulbfedcyzmsqgdxpau"]
boxset = boxnum.to_set
numtwixe = 0
numtrhrice = 0
boxnum.each do |n|
  meh2 = 0
  meh3 = 0
  n.chars.each do |m|
    #puts n.count("#{m}")
    if (n.scan(/(?=#{m})/).count == 2)
      meh2 += 1
    elsif (n.scan(/(?=#{m})/).count == 3)
      meh3 += 1
    end
  end
  if (meh2 != 0)
    numtwixe += 1
  end
  if (meh3 != 0)
    numtrhrice += 1
  end
end
puts numtwixe * numtrhrice
#set implimentation, wasn't my first try
seen = Set.new
boxset.each do |s|
  s.each_char.with_index do |c, i|
    # Pair: [index, string with that index removed]
    pair = [i, s[0...i] + s[(i + 1)..-1]]
    if seen.include?(pair)
      puts pair[1] 
    end
    seen << pair
  end
end
#first try
boxnum.each_with_index do |d1, i|
  boxnum[i + 1..boxnum.size].each do |d2, j|
    diff = d1.each_char.with_index.count do |c, k|
      c != d2.chars[k]
    end
    if diff == 1
      puts [d1, d2] 
      break
    end
  end
end