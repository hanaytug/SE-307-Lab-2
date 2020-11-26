using System;

public class car
{
    public String model;
    private double year;
    private int speed;
    private int distance;

    public void Go(int newDistance)
    {
        distance += newDistance;
    }

    public void accelerate(int newSpeed)
    {
        speed = newSpeed;
        // Missing return statement or wrong method type
    }

    public void stop()
    {
        speed = 0;
        // Speed is int double to int is not valid.
    }

    public String getInfo()
    {
        return " Car Info : " + year + " " + model + ". Distance :" + distance
               + " km. and traveling at " + speed + " kmph ."; //, is not valid we should use +
    }

    /* GETTERS & SETTERS */
    public String getModel()
    {
        return model;
    }

    public void setModel(String model)
    {
        this.model = model;
    }

    public double getYear()
    {
        return year;
        // Year is double but the method is returning int
    }

    public void setYear(int year)
    {
        this.year = year;
    }

    public int getSpeed()
    {
        return speed;
    }

    public void setSpeed(int speed)
    {
        this.speed = speed;
    }

    public int getDistance()
    {
        return distance;
    }

    public void setDistance(int distance)
    {
        this.distance = distance;
    }
}