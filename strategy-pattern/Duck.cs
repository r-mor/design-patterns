using System;

public abstract class Duck{
	public IFly flyBehaviour;
	public IQuack quackBehaviour;

	public void performFly(){
		flyBehaviour.fly();
	}

	public void performQuack(){
		quackBehaviour.quack();
	}

	void display(){
		Console.WriteLine("This is a duck!");
	}

	void swim(){
		Console.WriteLine("Swim duck!");
	}
}

