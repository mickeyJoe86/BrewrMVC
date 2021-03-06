﻿// Set the dimensions of the canvas / graph
var margin = { top: 30, right: 20, bottom: 30, left: 50 },
    width = 600 - margin.left - margin.right,
    height = 270 - margin.top - margin.bottom;

// Set the ranges
var x = d3.scale.linear().range([0, width]);
var y = d3.scale.linear().range([height, 0]);

// Define the axes
var xAxis = d3.svg.axis().scale(x)
    .orient("bottom").ticks(7);

var yAxis = d3.svg.axis().scale(y)
    .orient("left").ticks(5);

// Define the line
var valueline = d3.svg.line()
    .x(function (d) { return x(d.index); })
    .y(function (d) { return y(d.temp); });

// Adds the svg canvas
var svg = d3.select("#dataContainer")
    .append("svg")
        .attr("width", width + margin.left + margin.right)
        .attr("height", height + margin.top + margin.bottom)
    .append("g")
        .attr("transform",
              "translate(" + margin.left + "," + margin.top + ")");

//d3.csv("data.csv", function(error, data) {
mashData.forEach(function (d) {
    d.index = d.index;
    d.value = d.value;
});

// Scale the range of the data
x.domain(d3.extent(mashData, function (d) { return d.index; }));
y.domain([d3.min(mashData, function (d) { return d.temp; }), d3.max(mashData, function (d) { return d.temp; })]);

// Add the valueline path.
svg.append("path")
    .attr("class", "line")
    .attr("d", valueline(mashData));

// Add the X Axis
svg.append("g")
    .attr("class", "x axis")
    .attr("transform", "translate(0," + height + ")")
    .call(xAxis);

// Add the Y Axis
svg.append("g")
    .attr("class", "y axis")
    .call(yAxis);

//});

