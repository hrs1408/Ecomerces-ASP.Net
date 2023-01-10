import {useEffect, useState} from "react";
import axios from "axios";
import {MdOutlineAddShoppingCart} from "react-icons/md";
import {useDispatch} from "react-redux";
import {addToCart} from "../../redux/feature/cartSlice";


const Products = () => {
    const dispatch = useDispatch();
    const [products, setProducts] = useState([]);
    const addCart = (product) => {
        dispatch(addToCart(product));
    }
    useEffect(() => {
        const fetchData = async () => {
            const result = await axios(
                'https://localhost:7087/Product/GetAll',
            );
            setProducts(result.data);
        };
        fetchData().then(r => console.log(r));
    }, []);
    return (
        <div className={'container mx-auto'}>
            <h4>Sản Phẩm</h4>
            <div className={'mt-4 grid grid-cols-6'}>
                {
                    products.map(product => (
                        <ProductItem key={product.id} product={product} addCart={addCart}/>
                    ))
                }
            </div>
        </div>
    )
}


const ProductItem = ({product, addCart}) => {
    return (
        <div className={'card w-[190px]'}>
            <div className={'p-2'}>
                <img className={'w-[190px] h-[190px]'}
                     src={(product.image !== '') ? product.image : 'https://www.printing.com/global/images/PublicShop/ProductSearch/prodgr_default_300.png'}
                     alt=""/>
            </div>
            <div className={'card-body'}>
                <h3 className={'text-sm truncate'}>{product.name}</h3>
                <p className={'card-text text-[#f57224] font-bold'}>{product.price} đ</p>
                <button onClick={() => addCart(product)}
                        className={'bg-[#f57224] text-white p-2 flex items-center justify-center gap-2 rounded w-full hover:opacity-80 transition'}>
                    <MdOutlineAddShoppingCart/> <span>Add to cart</span>
                </button>
            </div>
        </div>
    )
}

export default Products