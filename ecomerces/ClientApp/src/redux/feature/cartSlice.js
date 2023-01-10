import {createSlice} from "@reduxjs/toolkit";
import Swal from "sweetalert2";

const initialState = {
    items: localStorage.getItem('cart') ? JSON.parse(localStorage.getItem('cart')) : [],
    total: localStorage.getItem('total') ? JSON.parse(localStorage.getItem('total')) : 0,
}

const cartSlice = createSlice({
        name: 'cart',
        initialState,
        reducers: {
            addToCart: (state, action) => {
                if (state.items.length == 0) {
                    state.items.push(action.payload);
                    state.total += action.payload.price;
                    localStorage.setItem('cart', JSON.stringify(state.items));
                    localStorage.setItem('total', JSON.stringify(state.total));
                    Swal.fire(
                        'Good job!',
                        'Thêm sản phẩm thành công!',
                        'success'
                    )
                } else {
                    const index = state.items.findIndex(item => item.id === action.payload.id);
                    if (index !== -1) {
                        state.items[index].quantity += 1;
                        state.total += action.payload.price;
                        localStorage.setItem('cart', JSON.stringify(state.items));
                        localStorage.setItem('total', JSON.stringify(state.total));
                        Swal.fire(
                            'Good job!',
                            'Sản phẩm đã được cập nhật số lượng!',
                            'success'
                        )
                    } else {
                        state.items.push(action.payload);
                        state.total += action.payload.price;
                        localStorage.setItem('cart', JSON.stringify(state.items));
                        localStorage.setItem('total', JSON.stringify(state.total));
                        Swal.fire(
                            'Good job!',
                            'Thêm sản phẩm thành công!',
                            'success'
                        )
                    }
                }
            },
            removeToCart: (state, action) => {
                const index = state.items.findIndex(item => item.id === action.payload);
                state.total -= (state.items[index].price * state.items[index].quantity);
                state.items.splice(index, 1);
                localStorage.setItem('cart', JSON.stringify(state.items));
                localStorage.setItem('total', JSON.stringify(state.total));
                Swal.fire(
                    'Good job!',
                    'Xoá sản phẩm thành công!',
                    'success'
                )
            },
            updateToCart: (state, action) => {
                const index = state.items.findIndex(item => item.id === action.payload.id);
                console.log(action.payload.quantity)
                state.items[index].quantity = action.payload.quantity;
                state.total += (action.payload.quantity - state.items[index].quantity) * state.items[index].price;
                localStorage.setItem('cart', JSON.stringify(state.items));
                localStorage.setItem('total', JSON.stringify(state.total));
            }
        },
    })
;

export const {addToCart, removeToCart, updateToCart} = cartSlice.actions;

export default cartSlice.reducer;