import {useEffect, useState} from "react";
import {VscRemove} from "react-icons/vsc";
import {useDispatch, useSelector} from "react-redux";
import {removeToCart, updateToCart} from "../../redux/feature/cartSlice";

const Cart = () => {
    const dispatch = useDispatch();
    const [listProduct, setlistProduct] = useState([]);
    const cartItem = useSelector(state => state.cartSlice.items);
    const total = useSelector(state => state.cartSlice.total);
    useEffect(() => {
        if (cartItem) {
            setlistProduct(cartItem);
        }
    }, [cartItem, listProduct]);
    const remove = (id) => {
        dispatch(removeToCart(id));
    }
    return (
        <div className={'container mx-auto py-20'}>
            {
                listProduct.length > 0 ? (
                    listProduct.map(item => (
                        CartItem({item, remove})
                    ))) : (<div className={'text-center'}>Không có sản phẩm nào trong giỏ hàng</div>)
            }
            <div className={'mt-4'}>
                <div className={'ml-auto'}>
                    Tổng tiền: {total} đ
                </div>
                <button
                    className={'bg-[#f57224] text-white p-2 flex items-center justify-center gap-2 rounded w-full hover:opacity-80 transition mt-3'}>
                    <span>Thanh toán</span>
                </button>
            </div>
        </div>
    )
}

const CartItem = ({item, remove}) => {
   
    return (
        <div className={'flex items-center gap-6 border px-4 py-2 mb-2'} key={item.id}>
            <img src={item.image} alt="" className={'w-[100px] h-[100px]'}/>
            <div className={'card-body'}>
                {item.name}
            </div>
            <div className={'p-2'}>Số lượng: {item.quantity}</div>
            <div className={'text-[#f57224] font-bold'}>{item.quantity * item.price} đ</div>
            <button onClick={() => remove(item.id)} className={'p-3 border rounded'}>
                <VscRemove/>
            </button>
        </div>
    )
}

export default Cart;