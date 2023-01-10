import {configureStore} from "@reduxjs/toolkit";
import cart from "./feature/cartSlice";

export default configureStore({
    reducer: {
        cartSlice: cart
    }
})