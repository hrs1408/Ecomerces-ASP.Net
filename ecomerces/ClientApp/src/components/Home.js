import React, {Component} from 'react';
import SliderHome from "./SliderHome";
import Category from "./Category";
import Products from "./Products";

export class Home extends Component {
    static displayName = Home.name;
    render() {
        return (
            <div className={'bg-[#F5F5F5]'}>
                <SliderHome/>
                <Category/>
                <Products/>
            </div>
        );
    }
}
