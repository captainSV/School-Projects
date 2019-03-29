class Borbs
  def initialize(settype)
    @Firstbird = Bird.new(settype)
  end

  def add(type)
    borb = @Firstbird
    if(type == borb.type)
      borb.addData
    elsif(borb.next == nil)
      borb.addBird(type)
    else
      borb = borb.next
    end
  end

  def find(type)
    borb = @Firstbird
    while (borb.next != nil)
      if (type.downcase == borb.type.downcase)
        return borb.data
      else
        borb = borb.next
      end
    end
    return "We have not seen any of that bird, sorry."
  end
end

class Bird
  attr_reader :data, :type, :next
  def initialize(type)
    @data = 1
    @type = type
    @next
  end
  def addData
    @data += 1
  end
  def addBird(type)
    @next = Bird.new(type)
  end
end

testing = Borbs.new("pidgeon")
testing.add("finch")
puts testing.find("bluebird")
puts testing.find("finch")