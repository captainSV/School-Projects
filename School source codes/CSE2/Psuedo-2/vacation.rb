class Vacation
  def initialize(budget, destination)
    @budget = budget
    @destination = destination
  end
  def budgeting(price) #needs arguement for base class, other two have costs built in
    return "On budget" if @budget == price
    @budget > price ? "Price is #{@budget-price} under budget." : "Price is #{price-@budget}  over budget."
  end
  def getBudget
    @budget
  end
  def setBudget(a)
    @budget = a
  end
  def getDest
    @destination
  end
  def setDest(a)
    @destination = a
  end
end
class AllInclusive < Vacation
  def initialize(budget, destination,brand,rating,price)
    super(budget,destination)
    @brand = brand
    @rating = rating
    @price = price
  end
  def budgeting
    return "On budget" if @budget == @price
    @budget > @price ? "Price is #{@budget-@price} under budget." : "Price is #{@price-@budget}  over budget."
  end
  def getBrand
    @brand
  end
  def setBrand(a)
    @brand = a
  end
  def getRating
    @rating
  end
  def setRating(a)
    @rating = a
  end
  def getPrice
    @price
  end
  def setPrice(a)
    @price = a
  end
end
class Peicemeal < Vacation
  def initialize(budget, destination, items,costs)
    super(budget,destination)
    @items = items
    @costs = costs
  end
  def budgeting
    return "On budget" if @budget == @costs.sum
    @budget > @costs.sum ? "Price is #{@budget-@costs.sum} under budget." : "Price is #{@costs.sum-@budget}  over budget."
  end
  def getItems
    @items
  end
  def getCosts
    @costs
  end
  def setItemsAndCosts(a,b)
    @items = a
    @costs = b
  end
end
dad = Vacation.new(10,"atlanta")
cad = AllInclusive.new(10,"atlanta","Holiday Inn",4, 12)
bad = Peicemeal.new(10,"atlanta",["hotel", "meal", "Gas"], [5,2,3])
p "Base testing:"
p dad.budgeting(15)
dad.setBudget(15)
p dad.getBudget
p dad.budgeting(15)
p "All Inclusive testing:"
p cad.budgeting
p cad.getBrand
p cad.getRating
p "Peicemeal testing:"
p bad.budgeting
p bad.getItems
bad.setItemsAndCosts(["hotel", "meal", "Gas", "Concert"], [5,2,3,4])
p bad.budgeting