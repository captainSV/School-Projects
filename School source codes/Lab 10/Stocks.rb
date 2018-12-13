class Stock
  def initialize(name,ticker)
    @Name,@Ticker,@prevClosingPrice,@currentPrice = name,ticker,1,1
  end
  def GetName 
    @Name
  end
  def GetTicker
    @Ticker
  end
  def Closing
    @prevClosingPrice
  end
  def Current
    @currentPrice
  end
  def GetChangePercent
    percentChange = (((@prevClosingPrice - @currentPrice)/@prevClosingPrice) * 100).round
    return "#{percentChange}%"
  end
  def SetClosing(tripe)
    @prevClosingPrice = tripe
  end
  def SetCurrent (tripe)
    @currentPrice = tripe
  end
  def to_s
    "#{@Name} stock's closing price is #{@prevClosingPrice}"
  end
end

test = Stock.new("Yahoo", "YHOO")
test2 = Stock.new("Google", "GOOG")
test.SetClosing(130.49)
test.SetCurrent(135.84)
test2.SetClosing(1350.72)
test2.SetCurrent(1402.67)
puts "Yahoo Stock:\nSymbol: #{test.GetTicker}\nClosing price: #{test.Closing}\nCurrent price: #{test.Current}\nPercent Change: #{test.GetChangePercent}"
print test
puts "\n\n"
puts "Google Stock:\nSymbol: #{test2.GetTicker}\nClosing price: #{test2.Closing}\nCurrent price: #{test2.Current}\nPercent Change: #{test2.GetChangePercent}"
print test2