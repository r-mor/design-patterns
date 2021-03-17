using System;

public class MallardDuck: Duck{
	public MallardDuck(){
		flyBehaviour = new FlyNoWay();
		quackBehaviour = new Quack();
	}
}
