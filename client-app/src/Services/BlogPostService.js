import axios from "axios";

const API_URL = "https://localhost:7151/api/BlogPost";

const getAllBlogPosts = () => {
    return axios.get(`${API_URL}/blogposts`);
};

const getBlogPostById = (id) => {
    return axios.get(`${API_URL}/${id}`);
};

const editBlogPost = (id, data) => {
    return axios.put(`${API_URL}/editBlogPost/${id}`, data);
};

export default {
    getAllBlogPosts,
    getBlogPostById,
    editBlogPost
};
